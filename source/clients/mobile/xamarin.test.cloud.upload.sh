#!/bin/bash

xamarin.test.cloud.upload.secure.sh

ANDROID_APK=./HolisticWare.Ph4ct3x/HolisticWare.Ph4ct3x.XamarinAndroid/bin/Release/HolisticWare.Ph4ct3x.Droid.apk
IOS_IPA=./HolisticWare.Ph4ct3x/HolisticWare.Ph4ct3x.XamarinIOS/bin/iPhone/Ad-Hoc/HolisticWarePh4ct3xiOS-1.0.ipa
UITEST_ASSEMBLY_FOLDER=./UIAcceptanceTest.HolisticWare.Ph4ct3x/bin/Debug

XAMARIN_UITEST_VERSION=0.8.0

mono \
	packages/Xamarin.UITest.$XAMARIN_UITEST_VERSION/tools/test-cloud.exe \
	submit \
		$ANDROID_APK \
	$API_KEY \
	--devices 02d9792e \
	--series "master" \
	--locale "en_US" \
	--user miljenko.cvjetko@xamarin.com \
	--assembly-dir \
		$UITEST_ASSEMBLY_FOLDER
		
		
		
mono \
	packages/Xamarin.UITest.$XAMARIN_UITEST_VERSION/tools/test-cloud.exe \
	submit \
		$IOS_IPA \
	$API_KEY \
	--devices 1a97f95f \
	--series "master" \
	--locale "en_US" \
	--user miljenko.cvjetko@xamarin.com \
	--assembly-dir \
		$UITEST_ASSEMBLY_FOLDER
