import Firebase from "firebase";

let config = {
  apiKey: "AIzaSyA3dL3jF-Jos5KR_dkc-24W-v5hM7T5mqU",
  authDomain: "bestappever-7ea3a.firebaseapp.com",
  databaseURL: "https://bestappever-7ea3a.firebaseio.com",
  projectId: "bestappever-7ea3a",
  storageBucket: "",
  messagingSenderId: "521433662652"
};

let fireapp = Firebase.initializeApp(config);
export const db = fireapp.database();