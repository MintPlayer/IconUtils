# IconExtractor
Split icons into multiple images
## NuGet package
https://www.nuget.org/packages/MintPlayer.IconUtils/
## Installation
### NuGet package manager
Open the NuGet package manager and install the **MintPlayer.IconUtils** package in the project
### Package manager console
Install-Package MintPlayer.IconUtils
## Usage
Simply call the following method:

    var icons = IconExtractor.Split(ofd.FileName);

## Copy-n-paste code sample

    var icons = IconExtractor.Split(ofd.FileName);

    var folder = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(ofd.FileName), "Split");
    if (!System.IO.Directory.Exists(folder)) System.IO.Directory.CreateDirectory(folder);
    var index = 1;
    foreach (var icon in icons)
    {
        var filename = System.IO.Path.Combine(folder, "icon_" + (index++).ToString() + ".ico");
        using (var fs = new System.IO.FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
        {
            icon.Save(fs);
        }
    }
