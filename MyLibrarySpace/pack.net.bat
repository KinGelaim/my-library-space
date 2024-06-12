nuget.exe pack MyLibrarySpace.nuspec
nuget delete MyLibrarySpace 1.0.0-alpha1 Password -source https://nuget/api/v1/package -noninteractive
nuget push MyLibrarySpace.1.0.0-alpha1.nupkg Password -source https://nuget/api/v1/package