class Record:
    def __init__(self, artist:str, albumTitle:str, trackCount: int, releaseYear: int, downloadCount: int) -> None:
        self.artist = artist
        self.albumTitle = albumTitle
        self.trackCount = trackCount
        self.releaseYear = releaseYear
        self.downloadCount = downloadCount