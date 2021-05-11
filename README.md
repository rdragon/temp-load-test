# Load test for support request
The project **LoadTester** has been deployed to the app service **p-e-onl-loadtest**, which runs in the **p-onl-api-plan** hosting plan that consists of two instances: RD00155D5778B2 and RD00155D579047.

The project **LoadTest.Client** is run from a local machine to generate the load. ARR Affinity is turned off so that both instances receive the same amount of requests. Each request performs the same computation and therefore both instances should roughly show the same CPU usage and same response times.

However, the average response time of the RD00155D5778B2 is at least three times as high as the average response time of the other instance. This is not only shown in the Metrics tab of the app service inside Azure, but can also be measured manually (e.g. using Postman). Also, the average CPU usage of the RD00155D5778B2 is at least twice as high as the average CPU usage of the other instance.

The load test was started at May 11, 06:36 PM UTC and ran for about two hours until 08:51 PM UTC. Here are some screenshots from the Metrics tab that show the statements made in the previous paragraph.

Both instances receive the same amount of requests:
![Number of requests during load test](https://peonlstorage.z6.web.core.windows.net/temp/load-test/load-test-requests.png)

The average response time of the RD00155D5778B2 is more than three times as high as the average response time of the other instance:
![Average response time during load test](https://peonlstorage.z6.web.core.windows.net//temp/load-test/load-test-response-time.png)

The average CPU usage of the RD00155D5778B2 is more than twice as high as the average CPU usage of the other instance:
![Average number of requests during load test](https://peonlstorage.z6.web.core.windows.net//temp/load-test/load-test-cpu-usage.png)


