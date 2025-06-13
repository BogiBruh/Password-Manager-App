import sys
import requests
import os

def scrapeLogo(inputString): #NEW AND IMPROVED SCRAPER
    inputString = str.lower(inputString)
    imgWritePath = "img\\logos\\" + inputString + ".png"
    #if you want to add a domain not listed here: fork the project on github, create a new branch where you'll submit your change and then create a pull request!
    domains = [".com", ".org", ".edu", ".co.uk", ".gov", 
               ".tv", ".io", ".to", ".ru", ".site"]

    if os.path.exists(imgWritePath):
        print("There is already an image here, no need to write one again.")
        return imgWritePath

    #Clearbit has a logo api that can be scraped 50k times a month for free per the docs, doubt any user would exceed that number 
    for domainExtension in domains:
        searchString = "https://logo.clearbit.com/" + inputString + domainExtension
    
        scraperRequest = requests.get(searchString, stream=True)

        if scraperRequest.status_code == 200:
            os.makedirs(os.path.dirname(imgWritePath), exist_ok=True)

            with open(imgWritePath, "wb") as scrapedImg:
                for byteChunks in scraperRequest.iter_content(1024):
                    if byteChunks:
                        scrapedImg.write(byteChunks)
                return

            print("Logo saved at " + imgWritePath)
        else:
            print(f"HTTP ERROR CODE {scraperRequest.status_code}")


scrapeLogo(sys.argv[1])