import Vue from "vue";
import VueFire from "vuefire";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import axios from 'axios'
import "./registerServiceWorker";
import BootstrapVue from 'bootstrap-vue'

Vue.config.productionTip = false;
Vue.use(VueFire);
Vue.use(BootstrapVue);
Vue.prototype.$axios = axios;
new Vue({
  router,
  store,
  render: h => h(App)
}).$mount("#app");
