from setuptools import setup

def readme():
    with open('README.rst') as f:
        return f.read()

setup(name='teamscritique',
      version='1.4',
      description='library for sentiment analysis for Teams call',
      long_description=readme(),
      url='https://github.com/rahul24/CritiqueForTeams',
      author='Xiao Yin',
      author_email='yinxiao@microsoft.com',
      keywords='Teams',
      license='MIT',
      packages=['teamscritique'],
      install_requires=[
          'librosa==0.8.0',
          'soundfile',
          'numpy==1.19.1',
          'sklearn',
          'pandas',
          'scipy',
          'pathlib',
          'markdown',
      ],
      include_package_data=True,
      zip_safe=False)