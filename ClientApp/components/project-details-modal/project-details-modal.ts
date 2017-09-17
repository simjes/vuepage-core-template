import Vue from 'vue';
import { Component, Prop } from 'vue-property-decorator';
import {IProject} from "../../helpers/IProject";

@Component
export default class ProjectDetailsModalComponent extends Vue {
	@Prop() 
	project: IProject;
	
}
