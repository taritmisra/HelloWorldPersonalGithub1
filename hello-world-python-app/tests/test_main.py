import unittest
from src.main import print_hello_world

class TestMain(unittest.TestCase):
    def test_print_hello_world(self):
        with self.assertLogs(level='INFO') as log:
            print_hello_world()
        self.assertIn("Hello World", log.output[0]) 

if __name__ == '__main__':
    unittest.main()