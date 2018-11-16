import Vue from "vue";
import Router from "vue-router";
import MemberTypes from "./views/team/MemberTypes";
import Tasks from "./views/team/Tasks";
import Members from "./views/team/Members";
import TaskDetails from "./views/team/TaskDetails";
import MemberDetails from "./views/team/MemberDetails";
import Statistics from "./views/team/Statistics";

import Home from "./views/Home";

import AuthTeamFind from "./views/AuthTeamFind";
import AuthTeamCreate from "./views/AuthTeamCreate";
import AuthTeamRegister from "./views/AuthTeamRegister";
import AuthTeamLogin from "./views/AuthTeamLogin";

import TeamDashboard from "./views/TeamDashboard";

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: "/",
      name: "Home",
      component: Home
    },
    {
      path: "/Auth/Team/Find",
      name: "AuthTeamFind",
      component: AuthTeamFind
    },
    {
      path: "/Auth/Team/Create",
      name: "AuthTeamCreate",
      component: AuthTeamCreate
    },
    {
      path: "/Auth/Team/:name/Register",
      name: "AuthTeamRegister",
      component: AuthTeamRegister,
      props: true
    },
    {
      path: "/Auth/Team/:name/Login",
      name: "AuthTeamLogin",
      component: AuthTeamLogin,
      props: true
    },
    {
      path: "/team/memberTypes",
      name: "MemberTypes",
      component: MemberTypes
    },
    {
      path: "/team/members",
      name: "Members",
      component: Members
    },
    {
      path: "/team/tasks",
      name: "Tasks",
      component: Tasks
    },
    {
      path: "/team/statistics",
      name: "Statistics",
      component: Statistics
    },
    {
      path: "/team/taskDetails",
      name: "TaskDetails",
      component: TaskDetails
    },
    {
      path: "/team/memberDetails",
      name: "MemberDetails",
      component: MemberDetails
    },
      path: "/Team/Dashboard",
      name: "TeamDashboard",
      component: TeamDashboard
    }
  ]
});
