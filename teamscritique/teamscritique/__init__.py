from .utils import extract_feature
from .utils import emotionsToLables
import pickle
#import pkgutil 
import numpy as np
from pathlib import Path

#data = pkgutil.get_data(__name__, "teamscritique/mlp_classifier.model")
resource_path = Path(__file__).parent
data = resource_path.joinpath("mlp_classifier.model")
model = pickle.load(open(data, "rb"))

def analyze(file = resource_path.joinpath("happy1.wav")):
    emotion = emotionsToLables[model.predict(np.array([extract_feature(file, mfcc=True, chroma=True, mel=True)]))[0]]
    return emotion