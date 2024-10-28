# Setup for XR hands-on workshop at 2024 DX camp

This document describes all the required steps that participants need to do to prepare for the workshop. The step cover several areas.

1. Create Unity account
2. Download and install Unity
3. Download and install tools for XR development
4. Prepare your project for XR development

After performing all the 4 steps from the list above, your development environment should be ready. To confirm it really is ready, you can check that in the top menu in Unity there is a Meta sub-menu. Additionally, check that you can run the project by pressing the play button. If there are no errors shown in the console, you are good to go.

### Create Unity account

If you already have Unity account, you can skip this chapter.
To create Unity account:
1. Go to [Unity ID account creation page](https://id.unity.com/en/conversations/c5e20087-c99d-440b-9b3d-ad972ee4b37901bf?view=register)
2. Fill out all the required fields.  
**IMPORTANT**: Please, use your private email for creating an account. We are not in breach of any rules if we use Zuehlke email for this, but Unity is quite cautious in detecting potential commercial usage of non-commercial accounts and will inquiry us to check. So, in order to avoid unneccessary explanations to Unity, please use your private email account.
3. Complete creation of your account.

### Download and install Unity

For this workshop, it is ideal that you have Unity 2022.3.2f1. To download and install Unity, follow the steps explained [here](https://developers.meta.com/horizon/documentation/unity/unity-before-you-begin/#unity). When applicable, choose the 2022.3.2 version.

It is also important to have a C# editor. If you don't have one already, during Unity installation you will be offered to install Visual Studio Community, which you can do. If you want, you can also use other editor of your choosing.

### Download and install tools for XR development

Before installing XR development tools, you must first create a Unity project. You can do that by following the instructions [here](https://developers.meta.com/horizon/documentation/unity/unity-package-manager#create-a-new-unity-project).

After you have created a project, you can import XR development packages. There are two ways of doing that. 
1. [Using Unity asset store](https://developers.meta.com/horizon/documentation/unity/unity-package-manager#download-and-import-packages-from-the-unity-asset-store). This is the approach I recommend.  
**NOTE**: When using the link from the instructions, you will see a page with various packages. The easiest way is to just choose [Meta XR All-in-One SDK](https://assetstore.unity.com/packages/tools/integration/meta-xr-all-in-one-sdk-269657).
2. [Using Meta's NPM registry](https://developers.meta.com/horizon/documentation/unity/unity-package-manager#download-and-import-packages-from-the-npm-registry). I never tried it this way, but it should be a feasible way to do it.

### Prepare your project for XR development

To prepare for XR development:
1. You must Oculus XR plugin. You can do that by following [these steps](https://developers.meta.com/horizon/documentation/unity/unity-project-setup#install-the-oculus-xr-plugin).
2. When you are done with that, you can configure the project with the project setup tool. Here are [the instructions](https://developers.meta.com/horizon/documentation/unity/unity-project-setup#configure-project-with-the-project-setup-tool) 