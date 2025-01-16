from Record import *

class Collection:
    def __init__(self) -> None:
        self.items:list = []

    def display_items(self) -> None:
        for item in self.items:
            print(f"Artist: {item.artist}\nAlbum: {item.albumTitle}\nTracks: {item.trackCount}\nYear: {item.releaseYear}\nDownloads: {item.downloadCount}\n")

    def overwrite_items(self,data:list) -> None:
        for index in range(0,len(data),6):
            self.items += [Record(data[index],data[index+1],data[index+2],data[index+3],data[index+4])]

    def read_file(self,fileName:str) -> list:
        with open(fileName, "r+") as file:
            data:list = file.read().split("\n")

        return data