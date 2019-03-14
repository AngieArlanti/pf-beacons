
# react-native-android-beacon-bridge

## Getting started

`$ npm install react-native-android-beacon-bridge --save`

### Mostly automatic installation

`$ react-native link react-native-android-beacon-bridge`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-android-beacon-bridge` and add `RNAndroidBeaconBridge.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAndroidBeaconBridge.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAndroidBeaconBridgePackage;` to the imports at the top of the file
  - Add `new RNAndroidBeaconBridgePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-android-beacon-bridge'
  	project(':react-native-android-beacon-bridge').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-android-beacon-bridge/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-android-beacon-bridge')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAndroidBeaconBridge.sln` in `node_modules/react-native-android-beacon-bridge/windows/RNAndroidBeaconBridge.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Android.Beacon.Bridge.RNAndroidBeaconBridge;` to the usings at the top of the file
  - Add `new RNAndroidBeaconBridgePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAndroidBeaconBridge from 'react-native-android-beacon-bridge';

// TODO: What to do with the module?
RNAndroidBeaconBridge;
```
  