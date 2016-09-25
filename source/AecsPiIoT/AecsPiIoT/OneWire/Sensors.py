class SensorOneWireDs18b20Class(object):
    def __init__(self, id=None, romid=None, health=None, temp=None, lastchecked=None, status=None, name=None, info=None):
        self.id = id
        self.romid = romid
        self.health = health
        self.temp = temp
        self.lastchecked = lastchecked
        self.status = status
        self.name = name
        self.info = info  

class SensorTempTest1(object):
    def __init__(self, id = None, status = None, name = None):
        self.id = id
        self.status = status
        self.bane = name