// gameDNA installer
// Created by Patryk Stepniewski
// Copyright (c) 2014-2017 gameDNA Ltd. All Rights Reserved.

#include "GameDNAinstaller.h"
#include "GameDNAinstallerCommands.h"

#define LOCTEXT_NAMESPACE "gameDNAinstallerModule"

void FGameDNAinstallerCommands::RegisterCommands()
{
	UI_COMMAND(OpenPluginWindow, "gameDNA", "SDK installer for gameDNA's plugins", EUserInterfaceActionType::Button, FInputGesture());
}

#undef LOCTEXT_NAMESPACE
