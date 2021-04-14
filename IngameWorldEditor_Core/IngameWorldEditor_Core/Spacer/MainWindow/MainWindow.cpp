// Supported with union (c) 2020 Union team
// Union SOURCE file

namespace GOTHIC_ENGINE {
	HOOK Hook_CGameManager_Init PATCH( &CGameManager::Init, &CGameManager::Init_Union );

	void CGameManager::Init_Union( HWND& hwnd ) {
		DestroyWindow( hwnd );
		hwnd = UI_CreateWindow();
		THISCALL( Hook_CGameManager_Init )(hwnd);
		ShowWindow( hwnd, SW_SHOW );
		ogame->GetWorldTimer()->SetTime( 12, 00 );
		ogame->game_frameinfo = TRUE;

		if( initScreen )
			InitScreen_Close();
	}
}