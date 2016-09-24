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

# Initialize the GPIO Pins


# Settings
dir_1wireOnBoard = '/sys/bus/w1/devices/'
dir_configFiles = '/etc/aecs'

#   All threads that is running in system
threads = {}  
#thtest = {}  

 

#   OnBoard 1-wire handling
class OnBoardOneWireHandling (threading.Thread):
    def __init__(self, threadID, name, counter):
        threading.Thread.__init__(self)
        self.threadID = threadID
        self.name = name
        self.counter = counter
        self.running = False;

    def run(self):
        self.running = True;
        FolderScanLastTime = 0;
        while(self.running):
            print("running!!!!")
            time.sleep(2)
            
            

        self.running = False;
        #return super().run()
    
    def stop(self):
        self.running = False
    


def hej(x):
    pass

def ReadValuesThread():
    pass


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
    
    while True:
        print("starting")
        print("hej")
        print("pelle")
        time.sleep(5)

    print("Ending")
    

if __name__ == "__main__":
    sys.exit(int(main() or 0))