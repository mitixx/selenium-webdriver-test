require "selenium-webdriver"
driver = Selenium::WebDriver.for :chrome
driver.navigate.to"http://google.com"
element = driver.find_element(:name, 'q')
element.send_keys "Hello WebDriver!!"
element.submit
puts driver.title
loop do
sleep 10
end
driver.quit