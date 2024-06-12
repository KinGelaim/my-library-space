nuget.exe pack MyLibrarySpace.nuspec
nuget delete MyLibrarySpace 1.0.0-alpha1 -source c:\nuget -noninteractive
nuget add MyLibrarySpace.1.0.0-alpha1.nupkg -source c:\nuget 