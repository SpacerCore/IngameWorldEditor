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

	static bool UpdateDInputEnabled = true;

	int UpdateDInput_Union();

	HOOK Hook_UpdateDInput PATCH( &UpdateDInput, &UpdateDInput_Union );

	int UpdateDInput_Union() { 
		if( !UpdateDInputEnabled )
			return 0;

		return Hook_UpdateDInput();
	}

	void Core_StopInput() {
		cmd << "Core_StopInput " << AHEX32( zinput ) << endl;
		UpdateDInputEnabled = false;
		ShowCursor( True );
	}

	void Core_StartInput() {
		cmd << "Core_StartInput " << AHEX32( zinput ) << endl;
		UpdateDInputEnabled = true;
		ShowCursor( False );
	}

	const char* Core_GetVobName( void* vob ) {
		return ((zCVob*)vob)->GetObjectName();
	}

	const char* Core_GetVobType( void* vob ) {
		return ((zCVob*)vob)->_GetClassDef()->className;
	}
}