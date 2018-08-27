# Xamarin Bindings

An example Visual Studio Solution which shows how to bind [Flomio's iOS SDK](https://github.com/flomio/flomio-sdk-ios) to Xamarin and use in iOS app. 

## Adding to new project

### Add FlomioSDKBindings project to your Solution

![Add Bindings project to your Solution](https://user-images.githubusercontent.com/8557070/44673597-e9ecfd00-aa23-11e8-94ba-292e94d0f4ce.png)

### Add reference to bindings project.

Drag the bindings project to the References folder in your project to create a reference.

![Add reference to bindings project.](https://user-images.githubusercontent.com/8557070/44673595-e9ecfd00-aa23-11e8-8e63-0f178323984d.png)

### Disable Bitcode

![Open With](https://user-images.githubusercontent.com/8557070/44673596-e9ecfd00-aa23-11e8-95ed-7780cdb59fa5.png)

Open the .csproj for your iOS application in a text editor of your choice (i.e. using right click > Open with TextEdit), search for the PropertyGroup for the release configuration that you need to turn off bit code for, i.e.:

`<PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|iPhone' ">`

Within that group, see if a MtouchEnableBitcode already exists and edit it, otherwise add:

`<MtouchEnableBitcode>false</MtouchEnableBitcode>`

## Use in new project

See ViewController.cs as a reference on how to configure, inialize the SDK and respond to reader events.

## Feedback 

Let us know if you have any questions by creatings a Github issue or posting on [our Forums.](https://flomio.com/forums/forum/ask-the-flomies/)
