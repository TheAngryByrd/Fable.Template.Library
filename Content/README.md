# Fable.MyLib

## How to use this templates ?

1. Add your code into `src` folder.
2. Add your test into `tests` folder. All the tests are run against [mocha](https://www.npmjs.com/package/mocha)
3. You can now run `build.cmd MochaTest`. This is build the lib for you and run the tests.

### Release

In order to push your package to [nuget.org][https://nuget.org] you need to add your API keys to `NUGET_KEY` environmental variable.
You can create a key [here](https://www.nuget.org/account/ApiKeys).

- Update RELEASE_NOTES with a new version, data and release notes [ReleaseNotesHelper](http://fake.build/apidocs/fake-releasenoteshelper.html).
Ex:

```
#### 0.2.0 - 30.04.2017
* FEATURE: Does cool stuff!
* BUGFIX: Fixes that silly oversight
```


- You can then use the Release target. This will:
  - make a commit bumping the version: Bump version to 0.2.0
  - publish the package to nuget
  - push a git tag

`./build.sh Release`
