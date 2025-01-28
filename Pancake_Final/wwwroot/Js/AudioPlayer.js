
window.playAudio = function (filePath) {
    const audioPlayer = document.getElementById('audioPlayer');
    if (audioPlayer) {
        audioPlayer.src = filePath;
        audioPlayer.load();
        audioPlayer.play().catch(function (error) {
            console.log("Error playing audio:", error);
        });
    } else {
        console.error("Audio player element not found");
    }
};