
// window.playAudio = function (filePath) {
//     console.log("Playing audio:", filePath);
//     const audioPlayer = document.getElementById('audioPlayer');
//     if (audioPlayer) {
//         console.log("Audio player found. Setting source...");
//         audioPlayer.src = filePath;
//         audioPlayer.load();
//         audioPlayer.play().catch(function (error) {
//             console.error("Error playing audio:", error);
//         });
//     } else {
//         console.error("Audio player element not found");
//     }
// };

function playAudio(filePath) {
    const audioPlayer = document.getElementById("audioPlayer"); // Get the audio player element
    if (audioPlayer) {
        audioPlayer.src = filePath; // Set the source of the audio player
        audioPlayer.play()          // Start playing the audio
            .then(() => console.log(`Playing: ${filePath}`))
            .catch((error) => console.error(`Error playing audio: ${error.message}`));
    } else {
        console.error("Audio player element not found!");
    }
}
