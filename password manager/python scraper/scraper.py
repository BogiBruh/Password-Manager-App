import selenium
import sys
from selenium import webdriver
from selenium.webdriver.common.by import By
import requests
import time

def scrapeLogo(inputString):
    print("herher")
    webDriving = webdriver.Chrome()
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
    with open(imgWritePath, "wb") as file:
        file.write(imageSrc.content)

    time.sleep(1)

    webDriving.quit()

scrapeLogo(sys.argv[1])