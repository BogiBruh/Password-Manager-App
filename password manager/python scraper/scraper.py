import selenium
import sys
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.chrome.options import Options
import requests
import time
import os

def scrapeLogo(inputString):
    print("herher")

    #Web driver options to make it invisible
    webDriverOptions = Options()
    #webDriverOptions.add_argument("--headless")
    #webDriverOptions.add_argument("--disable-gpu")


    webDriving = webdriver.Chrome(options=webDriverOptions)
    searchString = "https://duckduckgo.com/?q=" + inputString + "+transparent+logo+png&ia=images"
    webDriving.get(searchString)

    #Wait half a second to grab the images anchor tag
    time.sleep(0.5)
    imageTab = webDriving.find_element(By.LINK_TEXT, "Images")
    imageTab.click()

    #wait half a second for the images to load
    time.sleep(0.5)

    imgLink = None

    print("here")
    while imgLink == None:
        imgLink = webDriving.find_element(By.XPATH, "//img[@loading = 'lazy']")
        time.sleep(0.001)
        
    if imgLink == None:
        print("nema slike :(((((((")
    #print(imgLink.get_attribute("outerHTML"))
    print(imgLink.get_attribute("src"))
    imageSrc = requests.get(imgLink.get_attribute("src"))

    imgWritePath = "img\\logos\\" + inputString + ".png"
    print(imgWritePath)
    if not os.path.exists(imgWritePath):
        with open(imgWritePath, "wb") as file:
            file.write(imageSrc.content)
    else:
        print("There is already an image here, no need to write one again")

    time.sleep(1)

    webDriving.quit()

def scrapeLogoClearbit(inputString): #NEW AND IMPROVED SCRAPER
    inputString = str.lower(inputString)
    imgWritePath = "img\\logos\\" + inputString + ".png"

    if os.path.exists(imgWritePath):
        print("There is already an image here, no need to write one again.")
        return imgWritePath

    #Clearbit has a logo api that can be scraped 50k times a month for free per the docs, doubt any user would exceed that number 
    searchString = "https://logo.clearbit.com/" + inputString + ".com"
    
    scraperRequest = requests.get(searchString, stream=True)

    if scraperRequest.status_code == 200:
        os.makedirs(os.path.dirname(imgWritePath), exist_ok=True)

        with open(imgWritePath, "wb") as scrapedImg:
            for byteChunks in scraperRequest.iter_content(1024):
                if byteChunks:
                    scrapedImg.write(byteChunks)

        print("Logo saved at " + imgWritePath)
    else:
        print(f"HTTP ERROR CODE {scraperRequest.status_code}")


scrapeLogoClearbit(sys.argv[1])