//Play function
window.playCurrentAudio = function (songUrl) {
    if (!songUrl) {
        console.log("❌ Error: No song URL provided.");
        return;
    }

    let audio = new Audio(songUrl);

    audio.onended = function () {
        console.log("🎵 Song finished. Playing next...");
        DotNet.invokeMethodAsync('YourBlazorProjectNamespace', 'PlayNextSong');
    };

    // If audio exists, stop the current playback
    if (this.audio) {
        this.audio.pause();
        this.audio = null;
    }

    console.log("🎶 Playing:", songUrl);
    audio.play();

    this.audio = audio; // Assign the current audio instance to a property
};

// Pause function
window.pauseAudio = function (songUrl) {
    if (this.audio) {
        console.log("⏸️ Pausing the current song...");
        this.audio.pause();
    } else {
        console.log("⚠️ No song is currently playing to pause.");
    }

    this.audio = audio; // Assign the current audio instance to a property
};

window.skipAudio = function (songUrl) {

    if (!this.playlist || this.playlist.length === 0) {
        console.log("⚠️ No playlist loaded.");
        return;
    }

    this.currentSongIndex++;
    if (this.currentSongIndex >= this.playlist.length) {
        console.log("✅ End of the playlist.");
        this.currentSongIndex = 0; // Optionally loop back to the first song
        return;
    }

    console.log("⏭️ Skipping to the next song...");
    this.playAudio(this.playlist[this.currentSongIndex], this.playlist);

    this.audio = audio; // Assign the current audio instance to a property

}

window.previousAudio = function (songUrl) {
    if (!this.playlist || this.playlist.length === 0) {
        console.log("⚠️ No playlist loaded.");
        return;
    }

    this.currentSongIndex--;
    if (this.currentSongIndex < 0) {
        console.log("✅ Beginning of the playlist.");
        this.currentSongIndex = this.playlist.length - 1; // Optionally loop back to the last song
        return;
    }

    console.log("⏮️ Skipping to the previous song...");
    this.playAudio(this.playlist[this.currentSongIndex], this.playlist);

    this.audio = audio; // Assign the current audio instance to a property
}


