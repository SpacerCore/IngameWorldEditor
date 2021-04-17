// Supported with union (c) 2020 Union team
// Union SOURCE file

namespace GOTHIC_ENGINE {
	HMODULE LoadLibraryUI() {
		HMODULE pluginUI = LoadLibraryAST( IngameWorldEditor_UI );
		if( !pluginUI )
			Message::Fatal( string::Combine( "%t not found!", IngameWorldEditor_UI ) );

		return pluginUI;
	}

	void* LoadSymbolUI( const string& symName ) {
		if( Union.GetEngineVersion() != ENGINE )
			return Null;

		static HMODULE pluginUI = LoadLibraryUI();
		void* proc = GetProcAddress( pluginUI, symName );
		if( proc == Null )
			Message::Fatal( string::Combine( "Symbol %s not found in %t", symName, IngameWorldEditor_UI ) );

		return proc;
	}

	int UpdateDInput_Union() { return 0;  }

	HOOK Hook_UpdateDInput PATCH_IF( &UpdateDInput, &UpdateDInput_Union, false );

	void Core_StopInput() {
		cmd << "Core_StopInput " << AHEX32( zinput ) << endl;
		if( !zinput )
			return;
		
		zinput->SetDeviceEnabled( zTInputDevice::zINPUT_MOUSE,		False );
		zinput->SetDeviceEnabled( zTInputDevice::zINPUT_KEYBOARD, False );
		Hook_UpdateDInput.Commit();
	}

	void Core_StartInput() {
		cmd << "Core_StartInput " << AHEX32( zinput ) << endl;
		if( !zinput )
			return;

		zinput->SetDeviceEnabled( zTInputDevice::zINPUT_MOUSE,		True );
		zinput->SetDeviceEnabled( zTInputDevice::zINPUT_KEYBOARD, True );
		Hook_UpdateDInput.Detach();
	}

	const char* Core_GetVobName( void* vob ) {
		return ((zCVob*)vob)->GetObjectName();
	}

	const char* Core_GetVobType( void* vob ) {
		return ((zCVob*)vob)->_GetClassDef()->className;
	}
}