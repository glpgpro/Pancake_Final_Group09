
window.playAudio = function (filePath) {
    console.log("Playing audio:", filePath);
    const audioPlayer = document.getElementById('audioPlayer');
    if (audioPlayer) {
        console.log("Audio player found. Setting source...");
        audioPlayer.src = filePath;
        audioPlayer.load();
        audioPlayer.play().catch(function (error) {
            console.error("Error playing audio:", error);
        });
    } else {
        console.error("Audio player element not found");
    }
};