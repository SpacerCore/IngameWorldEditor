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
}