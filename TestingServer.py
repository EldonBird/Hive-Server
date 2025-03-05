from flask import Flask, request
from datetime import datetime

app = Flask(__name__)

def output_callback(data):
    for i in range(len(data)):
        print(i)

@app.post('/submission')
def submission():


    output = []
    for i in request.form():
        output.append(i)

    output_callback(output)
    return str("complete")





if __name__ == "__main__":
    app.run(host='0.0.0.0', port=52067)
