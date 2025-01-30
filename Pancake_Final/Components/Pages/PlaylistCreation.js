const songs = [
    { id: 1, title: "Song 1", artist: "Artist A", duration: "3:45" },
    { id: 2, title: "Song 2", artist: "Artist B", duration: "4:10" },
    { id: 3, title: "Song 3", artist: "Artist C", duration: "2:55" }
];

const availableSongsList = document.getElementById("availableSongs");
const selectedSongsList = document.getElementById("selectedSongs");
const selectedSongs = new Set();

// Populate Available Songs
songs.forEach(song => {
    const li = document.createElement("li");
    li.innerHTML = `
        ${song.title} - ${song.artist} (${song.duration})
        <button onclick="selectSong(${song.id})">Add</button>
    `;
    availableSongsList.appendChild(li);
});

// Select Song
function selectSong(songId) {
    const song = songs.find(s => s.id === songId);
    if (!selectedSongs.has(songId)) {
        selectedSongs.add(songId);
        const li = document.createElement("li");
        li.id = `selected-${songId}`;
        li.innerHTML = `
            ${song.title} - ${song.artist} (${song.duration})
            <button onclick="removeSong(${songId})">Remove</button>
        `;
        selectedSongsList.appendChild(li);
    }
}

// Remove Song
function removeSong(songId) {
    selectedSongs.delete(songId);
    const li = document.getElementById(`selected-${songId}`);
    li.remove();
}

// Save Playlist
function savePlaylist() {
    const name = document.getElementById("playlistName").value;
    const description = document.getElementById("description").value;

    if (!name || selectedSongs.size === 0) {
        alert("Please fill in the playlist name and select at least one song.");
        return;
    }

    alert(`Playlist "${name}" created with ${selectedSongs.size} song(s)!`);
}

// Clear Form
function clearForm() {
    document.getElementById("playlistForm").reset();
    selectedSongs.clear();
    selectedSongsList.innerHTML = "";
}

function ErrorHandling() {
    Console.WriteLine("Its Working Mate");
}