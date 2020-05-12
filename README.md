# c4f-filerouter
MSDN - Coding 4 Fun - File Router
_Imported from [CodePlex archive](https://archive.codeplex.com/?p=filerouter)_

**Project Description**  
This projects implements a File Router, which monitors a path on the hard drive and moves files to appropriate locations based on matching certain patterns. For example, .avi and .wmv to Movies, .doc and .ppt to Documents.

## Introduction

This project was inspired by the many times I've come across catch-all folders on people's hard drives. Maybe you've got them too. Perhaps it's a documents folder where every file goes uncategorized. I also see downloads folders that contain Zip files, PDF documents, photos, installers and anything else downloaded. Internet Explorer and Firefox download to a single folder unless overridden. Many users either don't know how to manage folders or just don't spend the time to do so. From these observations I decided it would be nice to do something to reduce this burden, and thus, File Router was born.  
  
File Router acts by monitoring a path on the hard drive, then moving files to appropriate locations based on matching certain patterns. The application is fairly basic, with plenty of opportunity for extension. That's a plus for you, not a cop-out for me\!  

## How it works

There are only a few things to know. The **Source** field is the directory that File Router will monitor. Check the **Scan source directory recursively** checkbox if there are subfolders to watch.  
  
The **Mappings** area needs a little more explanation. The big ListBox shows any existing mappings. To add one, type in a list of strings to watch for in filenames, select a destination, then click **Add**. You can select a row in the list and click **Remove** to get rid of it, but you can't edit it. Sorry, but it's remove and re-add at this point. That's a great enhancement if someone wants to pitch in.  
  
The only trick with the **Expression** field is that you can multiple patterns set up to route to the same destination. Each much be separated by a comma. These should probably be regular expressions, but are just simple *Contains* matches. For a file extension, just specify it with the "dot" like ".avi" so it doesn't find "avi" in the middle of a different filename.  
  
Example for Office docs: .pptx,.ppt,.doc,.docx \
Videos: .avi,.wmv,.mpg  
  
![FileRouter.png](docs/images/84c99f7f-17c8-46d4-8a95-aef344701733.png
"FileRouter.png")  
  
Once you've set it up, use the taskbar notification icon to enable
automatic watching, or to scan manually. Otherwise it won't do a
thing.  
  
![FileRouter-Menu.png](docs/images/a2a69c35-4deb-4967-9c38-574612500447.png
"FileRouter-Menu.png")

_Note: This code was originally published as part of an MSDN Coding 4 fun [article](https://channel9.msdn.com/coding4fun/articles/Building-an-Automatic-Pattern-Based-File-Router)._