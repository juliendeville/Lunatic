#pragma once
<<<<<<< HEAD
#include <AK/SoundEngine/Common/AkSoundEngine.h>
=======
#include <AK/SoundEngine/Common/AkSoundEngine.h>
>>>>>>> 4e2c135e222557266bc5d964cd0e880d1fc46f39
#include "AkArrayProxy.h"
class AkExternalSourceArray;
namespace AK
{
	namespace SoundEngine
	{
		namespace DynamicSequence
		{
<<<<<<< HEAD
				/// Playlist Item for Dynamic Sequence Playlist.
			/// \sa
			/// - AK::SoundEngine::DynamicSequence::Playlist
			/// - AK::SoundEngine::PostEvent
			/// - \ref integrating_external_sources
			class PlaylistItem
			{
			public:
				PlaylistItem();
				PlaylistItem(const PlaylistItem& in_rCopy);
				~PlaylistItem();

				PlaylistItem& operator=(const PlaylistItem& in_rCopy);
				bool operator==(const PlaylistItem& in_rCopy)
				{
					AKASSERT(pExternalSrcs == NULL);
					return audioNodeID == in_rCopy.audioNodeID && 
						msDelay == in_rCopy.msDelay && 
						pCustomInfo == in_rCopy.pCustomInfo;
				};

				/// Sets the external sources used by this item.
				/// \sa 
				/// \ref integrating_external_sources
				AKRESULT SetExternalSources(AkUInt32 in_nExternalSrc, AkExternalSourceInfo* in_pExternalSrc);

				/// Get the external source array.  Internal use only.
				AkExternalSourceArray* GetExternalSources(){return pExternalSrcs;}

				AkUniqueID audioNodeID;	///< Unique ID of Audio Node
				AkTimeMs   msDelay;		///< Delay before playing this item, in milliseconds
				void *	   pCustomInfo;	///< Optional user data

			private:
				AkExternalSourceArray *pExternalSrcs;
			};

			/// List of items to play in a Dynamic Sequence.
=======
				/// Playlist Item for Dynamic Sequence Playlist.
			/// \sa
			/// - AK::SoundEngine::DynamicSequence::Playlist
			/// - AK::SoundEngine::PostEvent
			/// - \ref integrating_external_sources
			class PlaylistItem
			{
			public:
				PlaylistItem();
				PlaylistItem(const PlaylistItem& in_rCopy);
				~PlaylistItem();

				PlaylistItem& operator=(const PlaylistItem& in_rCopy);
				bool operator==(const PlaylistItem& in_rCopy)
				{
					AKASSERT(pExternalSrcs == NULL);
					return audioNodeID == in_rCopy.audioNodeID && 
						msDelay == in_rCopy.msDelay && 
						pCustomInfo == in_rCopy.pCustomInfo;
				};

				/// Sets the external sources used by this item.
				/// \sa 
				/// \ref integrating_external_sources
				AKRESULT SetExternalSources(AkUInt32 in_nExternalSrc, AkExternalSourceInfo* in_pExternalSrc);

				/// Get the external source array.  Internal use only.
				AkExternalSourceArray* GetExternalSources(){return pExternalSrcs;}

				AkUniqueID audioNodeID;	///< Unique ID of Audio Node
				AkTimeMs   msDelay;		///< Delay before playing this item, in milliseconds
				void *	   pCustomInfo;	///< Optional user data

			private:
				AkExternalSourceArray *pExternalSrcs;
			};

			/// List of items to play in a Dynamic Sequence.
>>>>>>> 4e2c135e222557266bc5d964cd0e880d1fc46f39
		}
	}
}