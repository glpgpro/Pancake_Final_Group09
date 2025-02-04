window.playAudio = function (songUrl) {
    if (!songUrl) {
        console.log("❌ Error: No song URL provided.");
        return;
    }

    let audio = new Audio(songUrl);

    audio.onended = function () {
        console.log("🎵 Song finished. Playing next...");
        DotNet.invokeMethodAsync('YourBlazorProjectNamespace', 'PlayNextSong');
    };

    console.log("🎶 Playing:", songUrl);
    audio.play();
};