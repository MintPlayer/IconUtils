# MintPlayer.IconUtils
[![NuGet Version](https://img.shields.io/nuget/v/MintPlayer.IconUtils.svg?style=flat)](https://www.nuget.org/packages/MintPlayer.IconUtils)
[![NuGet](https://img.shields.io/nuget/dt/MintPlayer.IconUtils.svg?style=flat)](https://www.nuget.org/packages/MintPlayer.IconUtils)
[![Build Status](https://travis-ci.org/MintPlayer/MintPlayer.IconUtils.svg?branch=master)](https://travis-ci.org/MintPlayer/MintPlayer.IconUtils)
[![License](https://img.shields.io/badge/License-Apache%202.0-green.svg)](https://opensource.org/licenses/Apache-2.0)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/a3bb5690a393441cadbe6a119f6ecd9f)](https://www.codacy.com/gh/MintPlayer/MintPlayer.IconUtils?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=MintPlayer/MintPlayer.IconUtils&amp;utm_campaign=Badge_Grade)

Split icons into multiple images
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
