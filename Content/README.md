# Fable.Fable.MyLib


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



MacOS/Linux | Windows
--- | ---
[![Travis Badge](https://travis-ci.org/MyGithubUsername/Fable.MyLib.svg?branch=master)](https://travis-ci.org/MyGithubUsername/Fable.MyLib) | [![Build status](https://ci.appveyor.com/api/projects/status/github/MyGithubUsername/Fable.MyLib?svg=true)](https://ci.appveyor.com/project/MyGithubUsername/Fable.MyLib)
[![Build History](https://buildstats.info/travisci/chart/MyGithubUsername/Fable.MyLib)](https://travis-ci.org/MyGithubUsername/Fable.MyLib/builds) | [![Build History](https://buildstats.info/appveyor/chart/MyGithubUsername/Fable.MyLib)](https://ci.appveyor.com/project/MyGithubUsername/Fable.MyLib)


## Nuget

Stable | Prerelease
--- | ---
[![NuGet Badge](https://buildstats.info/nuget/Fable.MyLib)](https://www.nuget.org/packages/Fable.MyLib/) | [![NuGet Badge](https://buildstats.info/nuget/Fable.MyLib?includePreReleases=true)](https://www.nuget.org/packages/Fable.MyLib/)


