from setuptools import setup

setup(name='teamscritique',
      version='1.0',
      description='The funniest joke in the world',
      url='http://github.com/storborg/funniest',
      author='Xiao Yin',
      author_email='yinxiao@microsoft.com',
      license='MIT',
      packages=['teamscritique'],
      install_requires=[
          'librosa==0.8.0',
          'soundfile',
          'numpy==1.19.1',
          'sklearn',
          'pandas',
          'scipy',
      ],
      include_package_data=True,
      zip_safe=False)