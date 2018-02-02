# Geta.Epi.MediaReferenceSelector

## Description
This module replaces the built-in media content reference editors in Episerver and adds possibility to upload files directly without having to go the extra step through the assets panel.

## Features
* Replace media content reference property

## How to install

Install NuGet package (use [EPiServer Nuget](http://nuget.episerver.com))

    Install-Package Geta.Epi.MediaReferenceSelector

## How to use

Decorate the content reference property as usual:

    [UIHint(UIHint.Image)]
    public virtual ContentReference MyImage { get; set; }

Or:

    [UIHint(UIHint.MediaFile)]
    public virtual ContentReference MyFile { get; set; }

## Screenshots

![ScreenShot](/docs/media-reference-selector.jpg)

## Package maintainer
https://github.com/MattisOlsson

## Changelog
[Changelog](CHANGELOG.md)