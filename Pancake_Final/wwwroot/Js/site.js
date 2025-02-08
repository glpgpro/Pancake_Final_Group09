// window.playAudio = function (songUrl) {
//     if (!songUrl) {
//         console.log("❌ Error: No song URL provided.");
//         return;
//     }
//
//     let audio = new Audio(songUrl);
//
//     audio.onended = function () {
//         console.log("🎵 Song finished. Playing next...");
//         DotNet.invokeMethodAsync('YourBlazorProjectNamespace', 'PlayNextSong');
//     };
//
//     // If audio exists, stop the current playback
//     if (this.audio) {
//         this.audio.pause();
//         this.audio = null;
//     }
//    
//
//     console.log("🎶 Playing:", songUrl);
//     audio.play();
// };


window.playAudio() = {
    playlist: [], // Array to store song URLs
    currentSongIndex: 0, // Index of the currently playing song
    audio: null, // Audio object to manage playback

    // Function to initialize and play the first song
    playAudio: function (songUrl, buttonElement) {
        if (!songUrl) {
            console.log("❌ Error: No song URL provided.");
            return;
        }

        // Disable the button to prevent multiple clicks
        if (buttonElement) {
            buttonElement.disabled = true;
        }

        // If a song is already playing, stop it first
        if (this.audio) {
            console.log("⏹️ Stopping current song...");
            this.audio.pause();
            this.audio.currentTime = 0; // Reset to the beginning
        }

        // If audio exists, stop the current playback
        if (this.audio) {
            this.audio.pause();
            this.audio = null;
        }

        // If a song is already playing, stop it first
        if (this.audio) {
            console.log("⏹️ Stopping current song...");
            this.audio.pause();
            this.audio.currentTime = 0; // Reset to the beginning
        }

        this.audio = new Audio(songUrl);

        // Event: When the song ends, play the next one
        this.audio.onended = () => {
            console.log("🎵 Song finished. Playing next...");
            this.playNextSong();
        };

        // Start playback
        console.log("🎶 Playing:", songUrl);
        this.audio.play();
    },

    // Function to play the next song in the playlist
    playNextSong: function () {
        if (this.currentSongIndex + 1 < this.playlist.length) {
            this.currentSongIndex++;
            this.playAudio(this.playlist[this.currentSongIndex]);
        } else {
            console.log("✅ Playlist ended. No more songs to play.");
            // Optionally, reset the index to loop the playlist
            // this.currentSongIndex = 0;
        }
    },

    // Function to set the playlist
    setPlaylist: function (songUrls) {
        if (!Array.isArray(songUrls) || songUrls.length === 0) {
            console.log("❌ Error: Invalid playlist. Provide an array of song URLs.");
            return;
        }
        this.playlist = songUrls;
        this.currentSongIndex = 0; // Reset to the first song
        console.log("🎵 Playlist loaded:", this.playlist);
    },

    // Function to start playing from the first song
    startPlaylist: function () {
        if (this.playlist.length === 0) {
            console.log("❌ Error: Playlist is empty. Please add songs to the playlist.");
            return;
        }
        this.playAudio(this.playlist[this.currentSongIndex]);
    }
};
