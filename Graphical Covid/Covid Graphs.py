#NOTE: Values taken here are static and not realtime
import pandas as pd
import matplotlib.pyplot as pl
import numpy as np

ans='y'
while ans=='y' or ans=='Y':
    data={'State':['Maharastra','Tamil Nadu','Andhra Pradesh','Karnataka','Uttar Pradesh'],
      'Active':[178561,52364,84209,85006,52309],
      'Affected':[733568,403242,393090,309792,208419],
      'Recovered':[531563,343930,295498,219554,152893],
      'Deaths':[23444,6948,3633,5232,3217]}
 
    df=pd.DataFrame(data) 
    print(df)
    print();
    print("MENU \n 1.Line Graph \n 2.Scatter Plot \n 3.Bar Graph \n \
4.Pie Chart \n 5.Horizontal Bar Graph \n 6.Multiple Bar Graphs \n \
7.Custom \n 8.Exit")
    ch=int(input("Enter your choice-"))
    if ch==1:
        aux=input("Enter the desired column along with State-")
        col=input("Enter Desired Colour-")
        mark=input("Enter Desired Marker-")
        pl.xlabel("States")
        pl.ylabel(aux)
        pl.plot(df['State'],df[aux], color=col, marker=mark)
        pl.title("COVID-19 in India")
        pl.show()
    if ch==2:
        aux=input("Enter the desired column along with State-")
        col=input("Enter Desired Colour-")
        mark=input("Enter Desired Marker-")
        pl.xlabel("States")
        pl.ylabel(aux)
        pl.scatter(df['State'],df[aux], color=col, marker=mark)
        pl.title("COVID-19 in India")
        pl.show()
    if ch==3:
        aux=input("Enter the desired column along with State-")
        col=input("Enter Desired Colour-")
        pl.xlabel("States")
        pl.ylabel(aux)
        pl.bar(df['State'],df[aux],color=col)
        pl.title("COVID-19 in India")
        pl.show()
    if ch==4:
        aux=input("Enter the desired column along with State-")
        pl.pie(df[aux],labels=df['State'], shadow=True)
        pl.show()
    if ch==5:
        aux=input("Enter the desired column along with State-")
        col=input("Enter Desired Colour-")
        pl.xlabel(aux)
        pl.ylabel("States")
        pl.barh(df['State'],df[aux],color=col)
        pl.title("COVID-19 in India")
        pl.show()     
        
    if ch==6:
        x=np.arange(5)
        pl.bar(x,df['Affected'],color='blue', width=0.15,label='Affected')
        pl.bar(x+0.15,df['Active'],color='red', width=0.15,label='Active')
        pl.bar(x+0.3,df['Recovered'],color='green', width=0.15,label='Recovered')
        pl.bar(x+0.45,df['Deaths'],color='black',width=0.15,label='Deaths')
        pl.xticks(x,['Maharastra','Tamil Nadu','AP','Karnataka','UP'])
        pl.legend(loc='upper right')
        pl.title("COVID-19 in India")
        pl.show()
        
    if ch==7:
        kind=input("barh or bar : ")
        df.plot(kind=kind)
        pl.show()
        
    if ch==8:
        break
        
    res=input("Do you want to continue (Y/N)-")
    if res=='Y' or res=='y':
        continue
    else:
        break