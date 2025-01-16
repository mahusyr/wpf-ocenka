#aaaaa

from Collection import *

if __name__ == "__main__":
    collection:Collection = Collection()
    data:list = collection.read_file("Data.txt")

    collection.overwrite_items(data)
    collection.display_items()