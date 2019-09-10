from sklearn.cluster import KMeans
import matplotlib.pyplot as plt
import pandas as pd
import urllib.request,json
df=pd.read_csv("test.csv")
kmeans = KMeans(n_clusters=2, random_state=0).fit(df)
#What classifier things by seeing the data means grouping in 1 and 0
print(kmeans.labels_)
#here all value are inputed and predictes which group does it belong
print(kmeans.predict([[35.0,14.0,10.0,22.0,14.0,14.0,55.0,25.0,16.0,100.0]]))
data={}
with urllib.request.urlopen("http://theminimalist.esy.es/getrpmAR.php?name=fan") as url:
	data = json.loads(url.read().decode())
datax=data['r'][0]
#Print What value in temp
print(datax['temp'])
#Print the prediction
print(kmeans.predict([[int(datax['temp']),14.0,10.0,22.0,14.0,14.0,55.0,25.0,16.0,100.0]]))