// Supported with union (c) 2020 Union team
// Union SOURCE file

namespace GOTHIC_ENGINE {
  HOOK Hook_CGameManager_Init PATCH( &CGameManager::Init, &CGameManager::Init_Union );

  void CGameManager::Init_Union( HWND& hwnd ) {
    DestroyWindow( hwnd );
    hwnd = UI_CreateWindow();
    HWND renderView = UI_GetRenderView();
    THISCALL( Hook_CGameManager_Init )(renderView);
    UI_ShowWindow();
    UI_SetWindowText( "Ingame World Editor" );
    // ShowWindow( hwnd, SW_SHOW );
    ogame->GetWorldTimer()->SetTime( 12, 00 );
    ogame->game_frameinfo = TRUE;

    if( initScreen )
      InitScreen_Close();
  }

  HOOK Hook_zCRnd_D3D_XD3D_InitPerDX PATCH( &zCRnd_D3D::XD3D_InitPerDX, &zCRnd_D3D::XD3D_InitPerDX_Union );

  int zCRnd_D3D::XD3D_InitPerDX_Union( long flags, int x, int y, int bpp, int id ) {
    return THISCALL( Hook_zCRnd_D3D_XD3D_InitPerDX )( 0, x, y, bpp, id );
  }
}