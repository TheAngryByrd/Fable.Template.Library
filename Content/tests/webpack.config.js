var path = require('path');
var fs = require('fs');

function resolve(filePath) {
    return path.join(__dirname, filePath)
}

var babelOptions = {
    "presets": [
        [resolve("../node_modules/babel-preset-env"), {
            "modules": false
        }]
    ]
}

module.exports = {
    mode: "development", 
    entry: resolve('./Fable.MyLib.Tests.fsproj'),
    output: {
        filename: 'tests.bundle.js',
        path: resolve('./test'),
    },
    target: "node",
    module: {
        rules: [{
            test: /\.fs(x|proj)?$/,
            use: {
                loader: "fable-loader",
                options: {
                    babel: babelOptions
                }
            }
        }, {
            test: /\.js$/,
            exclude: /node_modules\/(?!fable)/,
            use: {
                loader: 'babel-loader'
            },
        }]
    },
};