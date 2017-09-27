import Vue from 'vue';
import { Component, Prop } from 'vue-property-decorator';
import {IProject} from "../../helpers/IProject";

declare var $: any;

@Component
export default class ProjectDetailsModalComponent extends Vue {
	@Prop() 
	project: IProject;
	
	mounted() {
		$("#modal-holder").focus();
	}
}
