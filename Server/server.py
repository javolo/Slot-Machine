import time
import BaseHTTPServer

class MyHandler(BaseHTTPServer.BaseHTTPRequestHandler):
	def do_GET(s):
		s.send_response(200)
		s.send_header("Content-Type", "text/html")
		s.end_headers()
		s.wfile.write("<html><head><title>Slot-Machine</title></head>")
		s.wfile.write("<body>Hello World</body></html>")
		
httpd = BaseHTTPServer.HTTPServer(("localhost", 80), MyHandler)
httpd.serve_forever()
