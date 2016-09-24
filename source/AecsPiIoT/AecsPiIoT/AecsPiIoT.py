#import ptvsd
#ptvsd.enable_attach('xplatdemo')

#import RPi.GPIO as GPIO
import io
import os
import time
import datetime
import sys
import threading
import signal
import glob
#from __builtin__ import str, int
from warnings import catch_warnings
from _ast import Str

# Initialize the GPIO Pins


# Settings
dir_OneWireOnBoard = '/sys/bus/w1/devices/'
dir_ConfigFiles = '/etc/aecs'

#   All threads that is running in system
threads = {}  
#thtest = {}  

#   1-wire On Board Temp sensor ds18b20
sensorOneWireOnBoardDs18b20List = []
sensorOneWireOnBoardDs18b20CrcWaitingTime = 30

class SensorOneWireDs18b20Class(object):
    def __init__(self, romid=None, health=None, temp=None, lastchecked=None, status=None, name=None, info=None):
        self.romid = romid
        self.health = health
        self.temp = temp
        self.lastchecked = lastchecked
        self.status = status
        self.name = name
        self.info = info  
         

#   OnBoard 1-wire handling
class OnBoardOneWireHandling (threading.Thread):
    def __init__(self, threadID, name, counter):
        threading.Thread.__init__(self)
        self.threadID = threadID
        self.name = name
        self.counter = counter
        self.running = False;

    def run(self):
        global sensorOneWireOnBoardDs18b20List
        self.running = True;
        FolderScanLastTime = 0;
        while(self.running):
            print("running!!!!")
            if time.time() - FolderScanLastTime > 60:
                self.getFoldersToScan()
                FolderScanLastTime = time.time()
            
            for oneWire in sensorOneWireOnBoardDs18b20List:
                returnId, returnStatus, returnTemp = self.readSensorData(oneWire.romid)
                if returnStatus is "ERROR":
                    oneWire.status = "missing"
                if returnStatus is "ERROR-CRC":
                    oneWire.status = "crc-error"                    
                if returnStatus is "OK":
                    oneWire.status = "OK"
                    oneWire.lastchecked = time.time()
                
                oneWire.temp = returnTemp
            time.sleep(2)
            
            

        self.running = False;
        #return super().run()
    
    def getFoldersToScan(self):
        global sensorOneWireOnBoardDs18b20List
        folders = glob.glob(dir_OneWireOnBoard + '28*')
        for folder in folders:
            id = os.path.basename(folder)
            #check if id exist or not in list
            idAlredyExist = False
            for oneWire in sensorOneWireOnBoardDs18b20List:
                if id in oneWire.romid:
                    idAlredyExist = True
            
            if idAlredyExist is False:
                    # this id dont exist. add this id
                    sensorOneWireOnBoardDs18b20List.append(SensorOneWireDs18b20Class(id,0,"-999",0,"new","new","new"))

    def readSensorData(self, sensorId):
        text = '';
        sensorReadingStartTime = time.time()
        try:
            while text.split("\n")[0].find("YES") == -1:
                tfile = open("/sys/bus/w1/devices/"+ sensorId +"/w1_slave")
                text = tfile.read()
                tfile.close()
                time.sleep(0.2)
                if time.time() - sensorReadingStartTime > sensorOneWireOnBoardDs18b20CrcWaitingTime:
                    #   This sensor have not got CRC = YES in more then x sec now.
                    return sensorId,"ERROR-CRC", -999
                #time.sleep(1)
            secondline = text.split("\n")[1]
            temperaturedata = secondline.split(" ")[9]
            temperature = float(temperaturedata[2:])
            temperatures = (temperature / 1000)
            return sensorId,"OK", temperatures
        except:
            return sensorId,"ERROR", -999

    def stop(self):
        self.running = False
    


#def hej(x):
#    pass

#def ReadValuesThread():
#    pass


#assert hej(3) 


def shutDown():
    print ("Stop all runnings threads")
    for t in threads:
        print('Thead: ' + str(threads[t].getName()) + ' will now stop()')
        threads[t].stop()
       
    print ("Wait 5 sec for threads to end")
    time.sleep(2);

    print ("Threads are joining before exit")
    for t in threads:
        threads[t].join()
    sys.exit(0)

def signal_handler(signal, frame):
    print ('You pressed Ctrl+C!')
    shutDown()

#   On Board 1-Wire Init
def OnBoardOneWireInit():
    if ("onboardOneWire" in threads):
        #   onboard One Wire is already init
        if (threads["onboardOneWire"].running == False):
            #   The thread is not running. start the Thread.
            threads["onboardOneWire"].start()
    else:
        #   Not init. do init
        os.system('modprobe w1-gpio')  # Turns on the GPIO module
        os.system('modprobe w1-therm') # Turns on the Temperature module
        thOnBoardOneWireHandling = OnBoardOneWireHandling("onboardOneWire","1-wire onboard",2)
        thOnBoardOneWireHandling.start();
        threads["onboardOneWire"] = thOnBoardOneWireHandling


def main():
    print("Starting!")

    #   Allow CTRL + c to shutdown the system
    signal.signal(signal.SIGINT, signal_handler)

    OnBoardOneWireInit();
    time.sleep(10)
    while True:
        for oneWire in sensorOneWireOnBoardDs18b20List:
            print("ID: " + oneWire.romid)
            print("Temp: " + str(round(oneWire.temp,2)))
            #print("ID: " + oneWire.romid + " Temp: " + str(round(oneWire.temp)))

        time.sleep(2)

    print("Ending")
    

if __name__ == "__main__":
    sys.exit(int(main() or 0))