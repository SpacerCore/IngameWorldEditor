// Supported with union (c) 2020 Union team
// Union SOURCE file

namespace GOTHIC_ENGINE {
	HOOK Hook_zCWorld_AddVobAsChild PATCH( &zCWorld::AddVobAsChild, &zCWorld::AddVobAsChild_Union );

	zCTree<zCVob>* zCWorld::AddVobAsChild_Union( zCVob* vob, zCTree<zCVob>* tree ) {
		auto subTree = THISCALL( Hook_zCWorld_AddVobAsChild )( vob, tree );
		UI_VobTree_Add( vob, tree->GetData() );
		return subTree;
	}

	HOOK Hook_zCWorld_RemoveVobSubtree PATCH_IF( &zCWorld::RemoveVobSubtree, &zCWorld::RemoveVobSubtree_Union, 0 );

	void zCWorld::RemoveVobSubtree_Union( zCVob* vob ) {
		//UI_VobTree_Remove( vob );
		THISCALL( Hook_zCWorld_RemoveVobSubtree )(vob);
	}

	HOOK Hook_zCWorld_MoveVobSubtreeTo PATCH_IF( &zCWorld::MoveVobSubtreeTo, &zCWorld::MoveVobSubtreeTo_Union, 0 );

	void zCWorld::MoveVobSubtreeTo_Union( zCVob* vob, zCTree<zCVob>* tree ) {
		UI_VobTree_Move( vob, tree->GetData() );
		THISCALL( Hook_zCWorld_MoveVobSubtreeTo )(vob, tree);
	}
}