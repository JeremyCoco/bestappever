import Vue from "vue";
import VueFire from "vuefire";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import "./registerServiceWorker";

Vue.config.productionTip = false;
Vue.use(VueFire);

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount("#app");
