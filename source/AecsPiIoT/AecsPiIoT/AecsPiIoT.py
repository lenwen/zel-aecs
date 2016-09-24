import ptvsd
ptvsd.enable_attach('xplatdemo')

import RPi.GPIO as GPIO
import io
import os

from math import sin, cos
import sys

# Initialize the GPIO Pins
os.system('modprobe w1-gpio')  # Turns on the GPIO module
os.system('modprobe w1-therm') # Turns on the Temperature module

# Settings
dir_1wireOnBoard = '/sys/bus/w1/devices/'

 


def hej(x):
    pass

def ReadValuesThread():
    pass


#assert hej(3) 


def main():
    while True:
        print("starting")
        print("hej")


    

if __name__ == "__main__":
    sys.exit(int(main() or 0))