import pyqrcode
import png

def qr_code():
    s='https://linktr.ee/rampageousrj'
    url=pyqrcode.create(s)
    url.png ('YTQRCode.png', scale=6)
    print('Code executed properly')
    
if __name__=='__main__':
    qr_code()