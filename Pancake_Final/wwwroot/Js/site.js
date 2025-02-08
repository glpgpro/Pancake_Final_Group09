// Play function
window.playCurrentAudio = function (songUrl) {
    if (!songUrl) {
        console.log("❌ Error: No song URL provided.");
        return;
    }

    // If the audio already exists and the same song is being played
    if (this.audio) {
        if (this.audio.src === songUrl) {
            if (this.audio.paused) {
                console.log("▶️ Resuming the current song...");
                this.audio.play();
            } else {
                console.log("⏸️ Pausing the current song...");
                this.audio.pause();
            }
            return;
        } else {
            // If a different song is selected, stop the current playback
            console.log("🔄 Switching to a new song...");
            this.audio.pause();
            this.audio = null;
        }
    }

    // Create a new audio instance for a new song
    let audio = new Audio(songUrl);

    // Attach event listeners
    audio.onended = function () {
        console.log("🎵 Song finished. Playing next...");
        DotNet.invokeMethodAsync('YourBlazorProjectNamespace', 'PlayNextSong');
    };

    console.log("🎶 Playing:", songUrl);
    audio.play();

    this.audio = audio; // Store the current audio instance
};

// Pause function (toggle behavior is handled in playCurrentAudio)
window.pauseAudio = function () {
    if (this.audio) {
        console.log("⏸️ Pausing the current song...");
        this.audio.pause();
    } else {
        console.log("⚠️ No song is currently playing to pause.");
    }
};

// Resume function (optional, if you want explicit play functionality)
window.resumeAudio = function () {
    if (this.audio && this.audio.paused) {
        console.log("▶️ Resuming the current song...");
        this.audio.play();
    } else {
        console.log("⚠️ No song is currently paused to resume.");
    }
};


