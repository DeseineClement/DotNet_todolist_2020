# DotNet_todolist_2020

A Short project make during my third year at [Epitech](http://www.epitech.eu/).
The main purpose is to create a basic todo list application on [Windows](https://www.microsoft.com/fr-fr/windows/). The project was developed in [C#](https://fr.wikipedia.org/wiki/C_sharp) with [Xamarin](https://www.xamarin.com/) and built with [MSBuild](https://docs.microsoft.com/fr-fr/visualstudio/).

## The project
This one-page application provide a simple and responsive todo list. The user can create his own task with three different informations: 


1. A title to name the main purpose of the task
2. A Body to add additional informations
3. A Due Date to Due Date to know the deadline of this task

The user can update these three informations next and select if the task has been done or not.
All Data are stocked in local with [SQLite](https://www.sqlite.org/).

## Xamarin

[Xamarin](https://www.xamarin.com/) is a solution powered by [Microsoft](https://www.microsoft.com) in 2011.
The main purpose of this technology is to provide a way for developers to  create native cross-platform applications.

### A Xamarin project organization

A [Xamarin](https://www.xamarin.com/) project is built with two or more assemblys:
 
A main cross-platform one named [PCL](https://developer.xamarin.com/guides/cross-platform/application_fundamentals/pcl/) (Portable Class Libraries)
One or more of the following:

1. A [Windows 10](https://www.microsoft.com/fr-fr/windows/) / [Windows Phone](https://fr.wikipedia.org/wiki/Windows_Phone) one named [UWP](https://docs.microsoft.com/fr-fr/windows/uwp/get-started/whats-a-uwp) (Universal Windows Platform)
2. An [Android](https://www.android.com/) one. It is possible to build this assembly by adding an [Android](https://www.android.com/) virtual machine to visual studio
3. An [IOS](https://developer.apple.com/ios/) one. It is possible to develop this assembly on each platform. However, in order to build that part of the [Xamarin](https://www.xamarin.com/) project, it is mandatory to have a [MacOS](https://developer.apple.com/macos/) environnement. Some [Microsoft](https://www.microsoft.com) Solutions such as [VSTS](https://www.visualstudio.com) provide [MacOS](https://developer.apple.com/macos/) environnement for this purpose.

The best practices is to develop as much as possible in the [PCL](https://developer.xamarin.com/guides/cross-platform/application_fundamentals/pcl/), then to override this one in each specific device assembly. By developing this way, it is possible de factorise almost all the code for each device.

Basically [Android](https://www.android.com/) project must be written te in [Java](https://fr.wikipedia.org/wiki/Java_(langage)) or recently [Kotlin](https://kotlinlang.org/), [IOS](https://developer.apple.com/ios/) one must also be written in [Objective C](https://fr.wikipedia.org/wiki/Objective-C) or [Swift](https://www.apple.com/fr/swift/). However Xamarin provide a solution to develop all assemblys in [C#](https://fr.wikipedia.org/wiki/C_sharp).

This project is built with a [PCL](https://developer.xamarin.com/guides/cross-platform/application_fundamentals/pcl/) assembly and a [UWP](https://docs.microsoft.com/fr-fr/windows/uwp/get-started/whats-a-uwp) one.

### Storing data with Entity Framework

[Xamarin](https://www.xamarin.com/) also includes [Entity Framework](https://docs.microsoft.com/en-us/ef/) which is the default ORM in [Windows 10](https://www.microsoft.com/fr-fr/windows/) projects. By this way it is possible to persist all data in a local storage with [SQLite](https://www.sqlite.org/).

For this project which has no online or multi-client feature, it is far more effective to use a local database than another one stocked in a server.

### Make your application responsive with Xamarin.Forms

[Xamarin.Forms](https://developer.xamarin.com/guides/xamarin-forms/) is the library used to develop cross-platform application views. There is two to way to do this:

1. Develop your views all in [C#](https://fr.wikipedia.org/wiki/C_sharp) by simply including [Xamarin.Forms](https://developer.xamarin.com/guides/xamarin-forms/) library.
2. Develop your views in [XAML](https://fr.wikipedia.org/wiki/XAML) and the actions implemented by some buttons, forms etc in [C#](https://fr.wikipedia.org/wiki/C_sharp)

It is also possible to bind some of the persisted data as a context for a specific range of the application page. There is two main advantages for implementing each views this way: 

1. The informations give in the views can be set dynamically depending of the selected data's values.
2. By marking the selected data as "Observable", each page can be responsive. That the binding part of the view can be automatically refreshed without reloading all parts that don't need to.


