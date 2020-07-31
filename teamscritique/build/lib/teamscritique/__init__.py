from .utils import extract_feature
from .utils import emotionsToLables
import pickle
import numpy as np

model = pickle.load(open("teamscritique/mlp_classifier.model", "rb"))
def analyze(file):
    emotion = emotionsToLables[model.predict(np.array([extract_feature(file, mfcc=True, chroma=True, mel=True)]))[0]]
    return emotion