from selenium import webdriver
driver = webdriver.Chrome()
driver.get("http://google.com")
element = driver.find_element_by_name('q')
element.send_keys("Hello WebDriver!!YEAH!!")
element.submit()
while true:
    sleep(10)
end
driver.quit()
