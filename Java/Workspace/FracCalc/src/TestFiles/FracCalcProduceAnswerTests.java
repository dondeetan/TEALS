package TestFiles;


import static org.junit.Assert.assertEquals;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Suite;

import com.sun.xml.internal.bind.v2.runtime.unmarshaller.XsiNilLoader.Array;

import fracCalc.FracCalc;
import fracCalc.FracCalcTestHelper;



public class FracCalcProduceAnswerTests {
	   @Test public void ValidateInput_ShouldBeCorrectFormat() 
	    {
		  assertEquals("Input is not in the correct format","4", FracCalc.produceAnswer("2 + 4"));		   
	    }
	   
	   @Test public void ValidateInput_ShouldNotBeCorrectFormat() 
	    {
		  assertEquals("Input is not in the correct format","Input Expression is not in the correct Format. Values and operators will be separated by a single space", FracCalc.produceAnswer("2 +"));		   
	    }
	   
	   @Test public void ValidateInput_ShouldBeCorrectFormatUsingFractions() 
	    {
		  assertEquals("Input is not in the correct format","1/4", FracCalc.produceAnswer("3_1/2 + 1/4"));		   
	    }
	   
	   @Test public void ValidateInput_ShouldBeCorrectFormatUsingFractionsReturnsOperand2() 
	    {
		  assertEquals("Input is not in the correct format","3_1/4", FracCalc.produceAnswer("3_1/2 + 3_1/4"));		   
	    }
	   
	   // ParseFraction Tests
	   @Test public void Validate_ParseFraction() throws Exception 
	    {
		   throw new Exception("Not Yet Implemented");   
	    }
	   
	   //TurnImproperFractionToMixedFraction Tests
	   @Test public void Validate_turnImproperFractionToMixedFraction() throws Exception 
	    {
		   throw new Exception("Not Yet Implemented");	   
	    }
}