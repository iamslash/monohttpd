# Usage

```bash
$ mono monohttpd 127.0.0.1 8080
```

# Test

```bash
$ vim req.json
```

~~~
{
  "request": {
    "slice": [
      {
        "origin": "ZRH",
        "destination": "DUS",
        "date": "2014-12-02"
      }
    ],
    "passengers": {
      "adultCount": 1,
      "infantInLapCount": 0,
      "infantInSeatCount": 0,
      "childCount": 0,
      "seniorCount": 0
    },
    "solutions": 20,
    "refundable": false
  }
}

~~~

```bash
$ curl -d @req.json --header "Content-Type: application/json" http://127.0.0.1:8080/ 
```
