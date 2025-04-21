import selenium
import sys
from selenium import webdriver
from selenium.webdriver.common.by import By
import requests
import time

def scrapeLogo(inputString):
    print("herher")
    webDriving = webdriver.Chrome()
    searchString = "https://duckduckgo.com/?q=" + inputString + "+logo+png"
    webDriving.get(searchString)

    imgLink = None
    starttime = time.time_ns()
    currentTime = starttime
    timeout = 5 * (10 ** (-9))
    print("here")
    while imgLink == None and currentTime - starttime < timeout:
        imgLink = webDriving.find_element(By.XPATH, "//img[@loading = 'lazy']")
        currentTime = time.time_ns()
        
    if imgLink == None:
        print("nema slike :(((((((")
    #print(imgLink.get_attribute("outerHTML"))
    print(imgLink.get_attribute("src"))
    imageSrc = requests.get(imgLink.get_attribute("src"))

    imgWritePath = "img\\logos\\" + inputString + ".png"
    print(imgWritePath)
    with open(imgWritePath, "wb") as file:
        file.write(imageSrc.content)

    time.sleep(3)

    webDriving.quit()

scrapeLogo(sys.argv[1])