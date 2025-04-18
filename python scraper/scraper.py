import selenium
from selenium import webdriver
from selenium.webdriver.common.by import By
import requests
import time

def scrapeLogo(inputString):
    searchString = "https://duckduckgo.com/?q=" + inputString + "-logo-png"
    webDriving.get(searchString)

    imgLink = webDriving.find_element(By.XPATH, "//img[@loading = 'lazy']")
    #print(imgLink.get_attribute("outerHTML"))
    print(imgLink.get_attribute("src"))
    imageSrc = requests.get(imgLink.get_attribute("src"))

    imgWritePath = "..\\img\\logos\\" + inputString + ".png"
    with open(imgWritePath, "wb") as file:
        file.write(imageSrc.content)


webDriving = webdriver.Chrome()

scrapeLogo("discord")
time.sleep(3)

webDriving.quit()